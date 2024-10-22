using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Abstract;
using EFDiyet2.DAL.Repository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Manager.Abstract
{
    public class Manager<TModel, TEntitiy> : IManager<TModel,TEntitiy> where TModel : class
    {
        protected IMapper _mapper;
        protected IRepository<TEntitiy> _repository;

        public Manager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.CreateMap<TModel, TEntitiy>().ReverseMap();

            });
            _mapper = new Mapper(config);
        }

        public void Add(TModel model)
        {
            TEntitiy entitiy = _mapper.Map<TEntitiy>(model);
            _repository.Insert(entitiy);

        }

        public void Delete(TModel model)
        {
            TEntitiy entity = _mapper.Map<TEntitiy>(model);
            _repository.Delete(entity);
        }

        public void Remove(TModel model)
        {
            TEntitiy entity = _mapper.Map<TEntitiy>(model);
            _repository.Remove(entity);
        }

        public void Update(TModel model)
        {
            TEntitiy entity = _mapper.Map<TEntitiy>(model);
            _repository.Update(entity);
        }

        public TModel GetById(int id)
        {
            TEntitiy entity = _repository.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }

        public TModel GetDeletedById(int id)
        {
            TEntitiy entity = _repository.GetDeletedById(id);
            TModel model= _mapper.Map<TModel>(entity);
            return model;
        }

        public List<TModel> GetAll()
        {
            List<TEntitiy> entities = _repository.GetAll().ToList();
            List<TModel> models = new List<TModel>();

            foreach (TEntitiy entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;

        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            Expression<Func<TEntitiy, bool>> predicateEntity = _mapper.Map<Expression<Func<TEntitiy, bool>>>(predicate);
            List<TEntitiy> entities = _repository.Search(predicateEntity).ToList();
            List<TModel> models = new List<TModel>();
            foreach (TEntitiy entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;
        }

        public List<TModel> GetAllById(int id)
        {
            List<TEntitiy> entities = _repository.GetAll().ToList();
            List<TModel> models = new List<TModel>();

            foreach (TEntitiy entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;
        }

        
        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

    }
}