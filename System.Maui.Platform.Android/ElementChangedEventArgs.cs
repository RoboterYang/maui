using System;

namespace System.Maui.Platform.Android
{
	public class ElementChangedEventArgs<TElement> : EventArgs where TElement : Element
	{
		public ElementChangedEventArgs(TElement oldElement, TElement newElement)
		{
			OldElement = oldElement;
			NewElement = newElement;
		}

		public TElement NewElement { get; private set; }

		public TElement OldElement { get; private set; }
	}
}