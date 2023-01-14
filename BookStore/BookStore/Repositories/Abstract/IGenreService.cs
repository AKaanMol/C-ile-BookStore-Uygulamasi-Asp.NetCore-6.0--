﻿using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        bool delete(int id);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}
