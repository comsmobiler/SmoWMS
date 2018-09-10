using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SMOWMS.CommLib
{
    /// <summary>
    /// 帮助类，用于基于DataAnnotations进行基础验证实体类
    /// </summary>
    public static class DataAnnotationHelper
    {
        /// <summary>
        /// 基础验证实体类
        /// </summary>
        public static IEnumerable<ModelValidationError> IsValid<T>(this T o)
        {
            var descriptor = GetTypeDescriptor(typeof(T));

            foreach (PropertyDescriptor propertyDescriptor in descriptor.GetProperties())
            {
                foreach (var validationAttribute in propertyDescriptor.Attributes.OfType<ValidationAttribute>())
                {
                    //原来的
                    //if (!validationAttribute.IsValid(propertyDescriptor.GetValue(o)))
                    //{
                    //    yield return new ModelValidationError() { FieldName = propertyDescriptor.DisplayName, Message = validationAttribute.FormatErrorMessage(propertyDescriptor.Name) };
                    //}
                    //新修改的


                    if (!validationAttribute.IsValid(propertyDescriptor.GetValue(o)))
                    {
                        yield return new ModelValidationError() { FieldName = propertyDescriptor.DisplayName, Message = validationAttribute.FormatErrorMessage(propertyDescriptor.Name) };
                    }
                }
            }
        }

        /// <summary>
        /// 得到需验证的属性信息
        /// </summary>
        private static ICustomTypeDescriptor GetTypeDescriptor(Type type)
        {
            return new AssociatedMetadataTypeTypeDescriptionProvider(type).GetTypeDescriptor(type);
        }
    }
}