public class LoyalListViewColumnHeader
{
	private int _width = 60;

	public string Text { get; set; }

	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			_width = value;
		}
	}

	public LoyalListViewColumnHeader()
	{
	}

	public LoyalListViewColumnHeader(string text)
	{
		Text = text;
	}

	public LoyalListViewColumnHeader(string text, int width)
	{
		Text = text;
		_width = width;
	}

	public override string ToString()
	{
		return Text;
	}
}
