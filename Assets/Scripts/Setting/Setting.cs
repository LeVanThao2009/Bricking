using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Setting : MonoBehaviour
{


	public static Setting Instance;

	void Awake()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy(gameObject);
	}
	[System.Serializable]
	public class ShopItem
	{
		public Sprite Image;
		public int Price;
		public bool IsPurchased = false;
	}

	public List<ShopItem> ShopItemsList;
	//GameObject g;
	[SerializeField] Transform ShopScrollView;
	[SerializeField] GameObject SettingPanel;
	Button buyBtn;

	public void OpenSetting()
	{
		SettingPanel.SetActive(true);
	}

	public void CloseSetting()
	{
		SettingPanel.SetActive(false);
	}

}
