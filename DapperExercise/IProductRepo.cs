﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExercise
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
		public void CreateProduct(string name, double price, int categoryID);
	}
}
