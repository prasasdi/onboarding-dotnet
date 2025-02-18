using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Tag.Repositories
{
    public class TagRepository(AppDbContext context, IHttpContextAccessor _httpContextAccessor)
    {
        private readonly IHttpContextAccessor _httpContextAccessor = _httpContextAccessor;
        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<ITag>> Pagination(IndexDto request)
        {
            var query = _context.Tags.AsQueryable();
            if (request.Search != null)
            {
                query = query.Where(i => EF.Functions.Like(i.Name, "%" + request.Search + "%"));
            }
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);

            var items = await query
           .Skip((request.Page - 1) * request.PerPage)
           .Take(request.PerPage)
           .ToListAsync();
            var httpContext = _httpContextAccessor.HttpContext;
            var baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.PathBase}{httpContext.Request.Path}";
            return new PaginateResponse<ITag>
            {
                Items = items.Cast<ITag>().ToList(),
                Pagination = new PaginationMeta
                {
                    Page = request.Page,
                    PerPage = request.PerPage,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    NextPageLink = request.Page < totalPages
                    ? $"{baseUrl}?Page={request.Page + 1}&PerPage={request.PerPage}"
                    : null,
                    PreviousPageLink = request.Page > 1
                    ? $"{baseUrl}?Page={request.Page - 1}&PerPage={request.PerPage}"
                    : null
                }
            };
        }

        public async Task<ITag?> FindOne(int id)
        {
            return await _context.Tags.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(TagCreateDto data)
        {
            var tag = new Database.Entities.Tag
            {
                Name = data.Name
            };

            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ITag tag, TagUpdateDto data)
        {
            tag.Name = data.Name;

            _context.Entry(tag).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Tags.Where(x => x.Id == id).ExecuteDeleteAsync();
        }


    }
}