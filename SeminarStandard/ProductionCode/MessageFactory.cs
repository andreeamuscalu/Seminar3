using SeminarStandard.ProductionCode;

namespace SeminarStandard
{
	internal class MessageFactory
	{
		public IFormatedMessage GetMessageByName(string name)
		{
			if (name.Contains("Queen") || name.Contains("King") || name.Contains("Prince") || name.Contains("Princess"))
			{
				return new RoyalMessage();
			}
			else if (name.Contains("bless"))
            {
				return new BlessingMessage();
            }
			else
			{
				if (!string.IsNullOrEmpty(name))
				{
					if (name != name.ToUpper())
						return new SimpleMessage();
					else
					{
						return new ShoutingMessage();
					}

				}
			}
			return null;
		}
	}
}