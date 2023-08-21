namespace Buberbreakfast.Contracts.Breakfast.UpsertBreakfastRequest
{

    public record UpsertBreakfastRequest (
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savoury,
    List<string> Sweet
    );
}

