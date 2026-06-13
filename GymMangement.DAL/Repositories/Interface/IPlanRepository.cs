using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GEAM_CORE.context;
using GEAM_CORE.Models;
using GymMangment.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GymMangment.DAL.Repositories.Interface
{
    public interface IPlanRepository
    {
        //Get All Plans
        Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default);
        //Get Plan By Id
        Task<Plan> GetByIdAsync(int id, CancellationToken ct = default);
        //Add Plan
        Task<int> AddAsync(Plan plan, CancellationToken ct = default);
        //Update Plan
        Task<int> UpdateAsync(Plan plan, CancellationToken ct = default);
        //  Delete Plan
        Task<int> DeleteAsync(Plan plan, CancellationToken ct = default);
    }
}

public class baseEntity
{
  // ...
}
public class Plan : baseEntity
{
  public int Id { get; set; }
  // ...
}
