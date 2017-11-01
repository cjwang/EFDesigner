﻿using System.ComponentModel;
using Sawczyn.EFDesigner.EFModel.DslPackage.CustomCode;

namespace Sawczyn.EFDesigner.EFModel
{
   internal sealed partial class EFModelPackage
   {
      protected override void Initialize()
      {
         TypeDescriptor.AddProvider(new ModelClassTypeDescriptionProvider(), typeof(ModelClass));
         TypeDescriptor.AddProvider(new ModelEnumTypeDescriptionProvider(), typeof(ModelEnum));
         TypeDescriptor.AddProvider(new AssociationTypeDescriptionProvider(), typeof(Association));

         Messages.Initialize(this);

         base.Initialize();
      }
   }
}
