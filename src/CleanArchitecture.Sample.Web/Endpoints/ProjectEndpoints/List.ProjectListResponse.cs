﻿
namespace CleanArchitecture.Sample.Web.Endpoints.ProjectEndpoints;

public class ProjectListResponse
{
  public List<ProjectRecord> Projects { get; set; } = new();
}