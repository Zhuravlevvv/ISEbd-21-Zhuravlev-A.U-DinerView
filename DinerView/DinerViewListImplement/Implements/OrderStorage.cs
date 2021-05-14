﻿using System;
using System.Collections.Generic;
using System.Linq;
using DinerBusinessLogic.BindingModels;
using DinerBusinessLogic.Interfaces;
using DinerBusinessLogic.ViewModels;
using DinerViewListImplement.Models;

namespace DinerViewListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton source;
        public OrderStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.SnackId = model.SnackId;
            order.ClientId = (int)model.ClientId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private OrderViewModel CreateModel(Order order)
        {
            string snackName = null;
            foreach (var snack in source.Snacks)
            {
                if (snack.Id == order.SnackId)
                {
                    snackName = snack.SnackName;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                SnackId = order.SnackId,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                SnackName = snackName,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                result.Add(CreateModel(order));
            }
            return result;
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Orders
            .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue &&
            rec.DateCreate.Date == model.DateCreate.Date) ||
            (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate.Date
            >= model.DateFrom.Value.Date && rec.DateCreate.Date <= model.DateTo.Value.Date) ||
            (model.ClientId.HasValue && rec.ClientId == model.ClientId))
            .Select(CreateModel)
            .ToList();
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var food in source.Orders)
            {
                if (food.Id == model.Id || food.SnackId ==
                    model.SnackId)
                {
                    return CreateModel(food);
                }
            }
            return null;
        }
        public void Insert(OrderBindingModel model)
        {
            Order tempOrder = new Order
            {
                Id = 1
            };
            foreach (var order in source.Orders)
            {
                if (order.Id >= tempOrder.Id)
                {
                    tempOrder.Id = order.Id + 1;
                }
            }
            source.Orders.Add(CreateModel(model, tempOrder));
        }
        public void Update(OrderBindingModel model)
        {
            Order tempOrder = null;
            foreach (var order in source.Orders)
            {
                if (order.Id == model.Id)
                {
                    tempOrder = order;
                }
            }
            if (tempOrder == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempOrder);
        }
        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].Id == model.Id)
                {
                    source.Orders.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
    }
}
