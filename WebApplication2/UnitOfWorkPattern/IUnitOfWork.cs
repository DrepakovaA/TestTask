using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Repository.AuthorRepository;
using WebApplication2.Repository.ImageRepository;

namespace WebApplication2.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IImageRepository ImageRepository { get; }

        Task SaveAsync();
    }
}
