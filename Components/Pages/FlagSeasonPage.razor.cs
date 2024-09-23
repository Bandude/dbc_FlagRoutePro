using dbc_FlagRoutePro.Entities;
using dbc_FlagRoutePro.Interfaces;
using dbc_FlagRoutePro.Services;

namespace dbc_FlagRoutePro.Components.Pages;

public partial class FlagSeasonPage
{
    private List<FlagSeason> flagSeasons = new List<FlagSeason>();
    private FlagSeason flagSeasonModel = new FlagSeason();
    private bool IsEditMode = false;

    protected override async Task OnInitializedAsync()
    {

        await LoadFlagSeasonsAsync();
        
    }
    private async Task LoadFlagSeasonsAsync()
    {
        flagSeasons = (await FlagSeasonService.GetAllAsync()).ToList();
    }
    private void EditFlagSeason(FlagSeason flagSeason)
    {
        flagSeasonModel = new FlagSeason
        {
            Id = flagSeason.Id,
            Name = flagSeason.Name,
            SubscriptionTypeId = flagSeason.SubscriptionTypeId,
            StartingDate = flagSeason.StartingDate,
            EndingDate = flagSeason.EndingDate
        };
        IsEditMode = true;
    }
    private void CancelEdit()
    {
        flagSeasonModel = new FlagSeason();
        IsEditMode = false;
    }
    private async Task SaveFlagSeason()
    {
        if (IsEditMode)
        {
            await FlagSeasonService.UpdateAsync(flagSeasonModel);
        }
        else
        {
            await FlagSeasonService.AddAsync(flagSeasonModel);
        }
        await LoadFlagSeasonsAsync();
        CancelEdit();
    }
    private async Task DeleteFlagSeason(int id)
    {
        await FlagSeasonService.DeleteAsync(id);
        await LoadFlagSeasonsAsync();
    }
}