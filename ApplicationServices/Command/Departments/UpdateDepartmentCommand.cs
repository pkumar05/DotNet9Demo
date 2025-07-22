﻿using Domain.DTO;
using Domain.Entities;

namespace ApplicationServices.Command
{
    public static class UpdateDepartmentCommand
    {
        /// <summary>
        /// Update command to add new department.
        /// </summary>
        /// <param name="department"></param>
        /// <param name="request"></param>
        /// <param name="createdBy"></param>
        /// <returns></returns>
        internal static async Task<Departments> UpdateDepartment(Departments dept, UpdateDepartmentRequest request, string modifyBy)
        {

            dept.Name = request.Name ?? dept.Name;
            dept.Code = request.Code ?? dept.Code;
            dept.Descriptions = request.Descriptions ?? dept.Descriptions;
            dept.UpdatedBy = modifyBy;
            dept.UpdatedDate = DateTime.Now;

            return await Task.Run(() => dept);

        }


    }
}
