using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;
/*
public class ActivitiesController :BaseApiControllers
{
    private readonly AppDbContext context;

    public ActivitiesController(AppDbContext context)
{
    this.context = context;
        this.context = context;
    }
}
*/

public class ActivitiesController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
    {
        return await context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Domain.Activity>> GetActivityDetail(string id)
    {
        var activity = await context.Activities.FindAsync(id);
        if (activity == null) return NotFound(); //BadRequest();
        return activity;
    }


}
