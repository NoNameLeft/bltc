﻿namespace BLTC.Web.ViewModels.Administration.Items
{
    using System.Collections.Generic;

    using AutoMapper;
    using BLTC.Data.Models;
    using BLTC.Services.Mapping;
    using BLTC.Web.ViewModels.Items;

    public class AllItemsViewModel : AllApprovedItemsViewModel, IMapFrom<Item>, IHaveCustomMappings
    {
        public override void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Item, AllItemsViewModel>();
        }
    }
}
