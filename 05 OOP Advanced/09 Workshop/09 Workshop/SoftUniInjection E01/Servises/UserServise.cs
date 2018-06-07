using SoftUniInjection_E01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Servises
{
    public class UserServise : IUserServise
    {
        private readonly IUserRepository userRepo;
        private readonly ISoftUniRepository softuniRepo;

        public UserServise(IUserRepository userRepo, ISoftUniRepository softuniRepo)
        {
            this.userRepo = userRepo;
            this.softuniRepo = softuniRepo;
        }

        public void Rename()
        {
            Console.WriteLine("User service called");
            Console.WriteLine("Servise calls User repo");
            this.userRepo.Print();
            Console.WriteLine("Service also calls Softuni repo");
            this.softuniRepo.Oop();
        }
    }
}
