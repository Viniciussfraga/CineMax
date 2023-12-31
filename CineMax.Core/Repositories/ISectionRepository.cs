﻿using CineMax.Core.Entities;

namespace CineMax.Core.Repositories
{
    public interface ISectionRepository : IRepository<Section>
    {
        Task<List<Section>> GetSectionsViewModelAsync(bool? disponible = false);
        Task<Section> GetSectionViewModelByIdAsync(int sectionId);
        Task UpdateSectionAsync(Section section);
    }
}
