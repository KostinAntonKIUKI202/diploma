﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class GroopsetController : Controller
    {
        private readonly IGroopsetRepository _groopsetRepository;
        public GroopsetController(IGroopsetRepository groopsetReposiotory)
        {
            _groopsetRepository = groopsetReposiotory;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Groopset> groopsets = await _groopsetRepository.GetAll();
            return View(groopsets);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateById()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Groopset groopset)
        {
            if (!ModelState.IsValid)
            {
                return View(groopset);
            }
            _groopsetRepository.Add(groopset);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Groopset groopset)
        {
            _groopsetRepository.Add(groopset);
            return RedirectToAction("CreateById");
        }
    }
}
