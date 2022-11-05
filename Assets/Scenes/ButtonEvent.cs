using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ButtonEvent : MonoBehaviour
{
	/// <summary>Japanese (ja) ボタンをクリックしたとき。</summary>
	public void OnClickJa()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("ja");
	}

	/// <summary>English (en) ボタンをクリックしたとき。</summary>
	public void OnClickEn()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("en");
	}

	/// <summary>Spanish (es) ボタンをクリックしたとき。</summary>
	public void OnClickEs()
	{
		LocalizationSettings.SelectedLocale = Locale.CreateLocale("es");
	}
}
