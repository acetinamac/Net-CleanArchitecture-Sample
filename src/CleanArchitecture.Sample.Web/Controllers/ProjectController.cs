﻿using CleanArchitecture.Sample.Core.ProjectAggregate;
using CleanArchitecture.Sample.Core.ProjectAggregate.Specifications;
using CleanArchitecture.Sample.SharedKernel.Interfaces;
using CleanArchitecture.Sample.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Sample.Web.Controllers;
[Route("[controller]")]
public class ProjectController : Controller
{
  private readonly IRepository<Project> _projectRepository;

  public ProjectController(IRepository<Project> projectRepository)
  {
    _projectRepository = projectRepository;
  }

  // GET project/{projectId?}
  [HttpGet("{projectId:int}")]
  public async Task<IActionResult> Index(int projectId = 1)
  {
    var spec = new ProjectByIdWithItemsSpec(projectId);
    var project = await _projectRepository.FirstOrDefaultAsync(spec);
    if (project == null)
    {
      return NotFound();
    }

    var dto = new ProjectViewModel
    {
      Id = project.Id,
      Name = project.Name,
      Items = project.Items
                    .Select(item => ToDoItemViewModel.FromToDoItem(item))
                    .ToList()
    };
    return View(dto);
  }
}
