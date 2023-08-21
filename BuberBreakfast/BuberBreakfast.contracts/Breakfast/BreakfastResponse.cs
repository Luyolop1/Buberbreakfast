namespace Buberbreakfast.Contracts.Breakfast.BreakfastResponse
{

    public record BreakfastResponse (
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savoury,
    List<string> Sweet
);

}




