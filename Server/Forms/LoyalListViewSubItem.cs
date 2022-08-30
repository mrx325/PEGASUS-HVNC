public class LoyalListViewSubItem
{
	public string Text { get; set; }

	public override string ToString()
	{
		return Text;
	}

	public LoyalListViewSubItem()
	{
	}

	public LoyalListViewSubItem(string text)
	{
		Text = text;
	}
}
