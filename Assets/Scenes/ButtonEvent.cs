using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ButtonEvent : MonoBehaviour
{
	/// <summary>Japanese (ja) �{�^�����N���b�N�����Ƃ��B</summary>
	public void OnClickJa()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("ja");
	}

	/// <summary>English (en) �{�^�����N���b�N�����Ƃ��B</summary>
	public void OnClickEn()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("en");
	}

	/// <summary>Spanish (es) �{�^�����N���b�N�����Ƃ��B</summary>
	public void OnClickEs()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("es");
	}
}
