﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class CategoryLogic
    {
        public static DAL.SetTableEntities1 db = new DAL.SetTableEntities1();
        #region כל הקטגוריות
        public static List<DTO.Category> GetAllCategories()
        {
            List<DTO.Category> categoriesDto = new List<DTO.Category>();
            List<DAL.Category> categories = db.Category.ToList();
            foreach (var item in categories)
            {
                categoriesDto.Add(DTO.Category.ConvertDBToDto(item));
            }
            return categoriesDto;
        }
        #endregion


        #region חיפוש קטגוריה לפי מזהה קטגוריה
        public static DTO.Category GetCategoryById(int idCategory)
        {
            DTO.Category category = DTO.Category.ConvertDBToDto(db.Category.Find(idCategory));
            if (category == null)
                return null;
            return category;
            }
        }
    #endregion
}
