namespace Buberbreakfast.Contracts.Breakfast.CreateBreakfastRequest{

    public record CreateBreakfastRequest (
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savoury,
    List<string> Sweet
    );
}

