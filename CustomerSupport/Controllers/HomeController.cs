using AutoMapper;
using CustomerSupport.BLL.Abstract;
using CustomerSupport.BLL.Models.Dtos;
using CustomerSupport.Extensions;
using CustomerSupport.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSupport.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnquireService _enquireService;
        public readonly IMapper _mapper;
        public readonly ILogger<HomeController> _logger;

        public HomeController(IEnquireService enquireService, IMapper mapper, ILogger<HomeController> logger)
        {
            _enquireService = enquireService;
            _mapper = mapper;
            _logger = logger;
        }
        /// <summary>
        /// Create enquire initial view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateEnquireVM());
        }

        /// <summary>
        /// To create an enquire
        /// </summary>
        /// <param name="createEnquireDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromForm] CreateEnquireDto createEnquireDto)
        {
            var createEnquireVM = _mapper.Map<CreateEnquireVM>(createEnquireDto);
            if (ModelState.IsValid)
            {
                var serviceResult = _enquireService.CreateInquire(createEnquireDto);
                if (serviceResult.Succeeded)
                {
                    TempData["Success"] = "Your feedback was successfully submitted";
                }
                else
                {
                    _logger.ErrorHappended(serviceResult.exception);
                    TempData["Errors"] = serviceResult.errors;
                }
            }
            else
            {
                ViewBag.Errors = ModelState.GetValidationErrors();
            }
            return View(createEnquireVM);
        }


    }
}