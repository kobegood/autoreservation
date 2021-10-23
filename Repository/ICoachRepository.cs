﻿using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICoachRepository
    {
        Task CreateCoaChTimeTable();
        Task CreateTable();
        Task<bool> InsertCoachData(List<CoachDTO> coaches);
        Task<List<CoachDTO>> SelectCoaches();
        Task<CoachTimeDTO> SelectCoachesTime(int id);
        Task<bool> UpdateDate(List<CoachDTO> coaches);

        Task<bool> InsertCoachTime(CoachDTO coach);
    }
}