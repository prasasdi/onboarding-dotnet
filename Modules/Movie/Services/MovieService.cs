using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Requests;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Movie.Repositories;

namespace onboarding_backend.Modules.Movie.Services
{
    public class MovieService(MovieRepository movieRepository)
    {
        private readonly MovieRepository _movieRepository = movieRepository;

        public async Task<PaginateResponse<IMovie>> Pagination(IndexDto request)
        {
            return await _movieRepository.Pagination(request);
        }

        public async Task Create(MovieCreateDto data)
        {
            await _movieRepository.Create(data);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await FindOne(id);

            if (movie is null) return false;

            await _movieRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, MovieUpdateDto data)
        {
            var movie = await FindOne(id);

            if (movie is null) return false;

            await _movieRepository.Update(movie, data);

            return true;
        }

        public async Task<IMovie> FindOne(int id)
        {
            return await _movieRepository.FindOne(id);
        }


    }
}