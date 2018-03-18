using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class AddFriendCommand
    {
        // AddFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            string requesterUsername = data[0];
            string addedFriendUsername = data[1];

            using (var context = new PhotoShareContext())
            {
                var requestingUser = context.Users
                    .Include(u => u.FriendsAdded)
                    .ThenInclude(fa => fa.Friend)
                    .FirstOrDefault(u => u.Username == requesterUsername);

                if (requestingUser == null)
                {
                    throw new ArgumentException($"{requesterUsername} not found!");
                }

                var addedFriend = context.Users
                    .Include(u => u.FriendsAdded)
                    .ThenInclude(fa => fa.Friend)
                    .FirstOrDefault(u => u.Username == addedFriendUsername);

                if (addedFriend == null)
                {
                    throw new ArgumentException($"{addedFriendUsername} not found!");
                }

                bool alreadyAdded = requestingUser.FriendsAdded.Any(u => u.Friend == addedFriend);

                bool accepted = addedFriend.FriendsAdded.Any(u => u.Friend == requestingUser);

                if (alreadyAdded && !accepted)
                {
                    throw new InvalidOperationException("Friend request already sent!");
                }

                if (!alreadyAdded && accepted)
                {
                    throw new InvalidOperationException($"{requesterUsername} has already received a friend request to {addedFriendUsername}");
                }

                if (alreadyAdded && accepted)
                {
                    throw new InvalidOperationException($"{addedFriendUsername} is already a friend to {requesterUsername}");
                }

                requestingUser.FriendsAdded.Add(new Friendship
                {
                    User = requestingUser,
                    Friend = addedFriend
                });

                context.SaveChanges();

                return $"Friend {addedFriendUsername} added to {requesterUsername}";
            }
        }
    }
}
