using State;

class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();

        // Initially in Draft state
        document.Edit(); // Document is being edited in Draft state.
        document.Review(); // Document is sent for review.

        // Now in Review state
        document.Edit(); // Document is under review and cannot be edited.
        document.Approve(); // Document is approved.

        // Now in Approved state
        document.Publish(); // Document is published.

        // Now in Published state
        document.Edit(); // Published document cannot be edited.
    }
}
