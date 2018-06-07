using CameraBazaar.Data.Models;
using CameraBazaar.Service.Contracts;
using CameraBazaar.Web.Infrastructure.Filters;
using CameraBazaar.Web.Models.CamerasViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Web.Controllers.Cameras
{
    public class CamerasController : Controller
    {
        private readonly ICameraService cameras;
        private readonly UserManager<User> userManager;
        public CamerasController(ICameraService cameras, UserManager<User> userManager)
        {
            this.cameras = cameras;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Add() => this.View();

        [HttpPost]
        [Authorize]
        public IActionResult Add(CameraFormViewModel cameraModel)
        {
            if (cameraModel.LightMatering == null || !cameraModel.LightMatering.Any())
            {
                ModelState.AddModelError(nameof(cameraModel.LightMatering), "Please select at least one light metering");
            }

            if (!ModelState.IsValid)
            {
                return View(cameraModel);
            }

            this.cameras.Create(
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutter,
                cameraModel.MaxShutter,
                cameraModel.MinISO,
                cameraModel.MaxISO,
                cameraModel.IsFullFrame,
                cameraModel.Resolution,
                cameraModel.LightMatering,
                cameraModel.Description,
                cameraModel.ImageUrl,
                this.userManager.GetUserId(User)
                );

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var cameraExists = this.cameras
                .IsCameraExists(id, this.userManager.GetUserId(User));

            if (cameraExists)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, CameraFormViewModel model)
        {
            var updatedCameras = this.cameras
                            .Edit(
                            id,
                            model.Make,
                            model.Model,
                            model.Price,
                            model.Quantity,
                            model.MinShutter,
                            model.MaxShutter,
                            model.MinISO,
                            model.MaxISO,
                            model.IsFullFrame,
                            model.Resolution,
                            model.LightMatering,
                            model.Description,
                            model.ImageUrl,
                            this.userManager.GetUserId(User));

            if (!updatedCameras)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
