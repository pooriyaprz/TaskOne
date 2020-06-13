using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Task1.IRepository;
using Task1.Models;
using Task1.ViewModels;

namespace Task1.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PropertyController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<IActionResult> Index()
        {
            var lstProperty = await _unitOfWork.Properties.GetAllByDetails();
            var res = _mapper.Map<IEnumerable<PropertyViewModel>>(lstProperty);
            return View(res);
        }

        public IActionResult Create()
        {
            var lstOwner = _unitOfWork.Owners.GetAll();
            var res = _mapper.Map<IEnumerable<OwnerViewModel>>(lstOwner);
            ViewBag.OwnerList = res;
            return View();
        }
        public IActionResult CreatePost(PropertyViewModel propertyViewModel)
        {
            var property = _mapper.Map<Property>(propertyViewModel);
            var owner = _unitOfWork.Owners.Get(propertyViewModel.OwnerId);
            property.Owner = owner;
            property.OwnerId = propertyViewModel.OwnerId;
            _unitOfWork.Properties.Add(property);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var lstOwner = _unitOfWork.Owners.GetAll();
            var res = _mapper.Map<IEnumerable<OwnerViewModel>>(lstOwner);
            ViewBag.OwnerList = res;
            var property = _unitOfWork.Properties.Get(id);
            var propRes = _mapper.Map<PropertyViewModel>(property);
            propRes.Id = property.Id;
            return View(propRes);
        }
        public IActionResult EditPut(PropertyViewModel propertyViewModel)
        {
            var property = _mapper.Map<Property>(propertyViewModel);
            var owner = _unitOfWork.Owners.Get(propertyViewModel.OwnerId);
            property.Owner = owner;
            property.OwnerId = propertyViewModel.OwnerId;
            _unitOfWork.Properties.Update(property);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        public IActionResult Delet(int id)
        {//
            if (id != 0)
            {
                var property = _unitOfWork.Properties.Get(id);
                _unitOfWork.Properties.Remove(property);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }else
            {
                return RedirectToAction("Index");
            }


        }
    }
}