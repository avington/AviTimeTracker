using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectTaskJournalEntriesResolver : ValueResolver<ProjectTask, List<JournalEntryViewModel>>
    {
        protected override List<JournalEntryViewModel> ResolveCore(ProjectTask source)
        {
            if (source == null || source.JournalEntries == null) return null;
            return
                source.JournalEntries.Select(
                    Mapper.Map<JournalEntry, JournalEntryViewModel>).ToList();
        }
    }
}