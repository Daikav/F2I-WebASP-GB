﻿using Microsoft.EntityFrameworkCore;
using MVMVC_EF.Data;
using MVMVC_EF.Models;
using System.ComponentModel.DataAnnotations;
using MVMVC_EF.Utilities;

namespace MVMVC_EF.ViewModels
{
    public class GroupVM : GenericVM
    {

        // views properties
        public string EntityName { get; set; } = "groupe";
 

        // models properties
        public List<Group>? Entities { get; set; }
        private int? _IDEntity;
        public int? IDEntity 
        {
            get => _IDEntity;
            set 
            {
                _IDEntity = value;
                if (_IDEntity != null)
                {
                    CurrentEntity = Context
                        .Group
                        .FirstOrDefault(p => p.Id == _IDEntity);
                    PageTitle = PageTitle
                        .Replace("[Entity]", CurrentEntity.ToString());
                }
            }
        }
        public Group? CurrentEntity { get; set; }


        // constructor
        public GroupVM() : base()
        { }
        public GroupVM(
            DBContext Context,
            eView View) 
            : base(Context, View)
        {

            Entities = Context.Group.ToList();

            UpdateControllerData(EntityName, View);

            PageTitle = PageTitle
                .Replace("[Nb]", Entities.Count().ToString());

        }

    }
}
