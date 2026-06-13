using GEAM_CORE.context;
using GEAM_CORE.Models;
using GymMangment.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangment.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymDbContexts dbContexts;

        public PlanRepository( GymDbContexts dbContexts)
        {
           this.dbContexts = dbContexts;
        }
        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            dbContexts.Plans.Add(plan);
            return await dbContexts.SaveChangesAsync(ct);
        }

        public Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            dbContexts.Plans.Remove(plan);
            return dbContexts.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
        {
            //IQueryable<Plan> query = tracking ? dbContexts.Plans : dbContexts.Plans.AsNoTracking();
            //   return await  query.ToListAsync(ct);
            if (tracking)
            {
                return await dbContexts.Plans.ToListAsync(ct);
            }
            else
            {
                return await dbContexts.Plans.AsNoTracking().ToListAsync(ct);
            }

        }

        public async Task<Plan> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await dbContexts.Plans.FindAsync(  id , ct);
        }

        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            dbContexts.Plans.Update(plan);
            return await dbContexts.SaveChangesAsync(ct);
        }
    }
}
