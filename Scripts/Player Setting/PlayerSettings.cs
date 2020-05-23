using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    
	readonly static string [] MAIN_GOLD_1= {" ","K","B","M","T","AA","BB","CC","DD","EE","FF","GG"
                                  		,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                  		,"RR","SS","TT","UU","VV","WW","XX","YY"};
	public static void setMainGold1(int size,float numb){
			PlayerPrefs.SetFloat(MAIN_GOLD_1[size],numb);
	}
	public static float getMainGold1(int numb) {
		return PlayerPrefs.GetFloat(MAIN_GOLD_1[numb]);
	}

	readonly static string [] MAIN_GOLD_2= {" ","K","B","M","T","AA","BB","CC","DD","EE","FF","GG"
                                  		,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                  		,"RR","SS","TT","UU","VV","WW","XX","YY"};
	public static void setMainGold2(int size,float numb){
			PlayerPrefs.SetFloat(MAIN_GOLD_2[size],numb);
	}
	public static float getMainGold2(int numb) {
		return PlayerPrefs.GetFloat(MAIN_GOLD_2[numb]);
	}

	readonly static string [] MAIN_GOLD_3= {" ","K","B","M","T","AA","BB","CC","DD","EE","FF","GG"
                                  		,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                  		,"RR","SS","TT","UU","VV","WW","XX","YY"};
	public static void setMainGold3(int size,float numb){
			PlayerPrefs.SetFloat(MAIN_GOLD_3[size],numb);
	}
	public static float getMainGold3(int numb) {
		return PlayerPrefs.GetFloat(MAIN_GOLD_3[numb]);
	}



    const string MAIN_SOUL = "main soul";

	public static void setMainSoul (float numb){
		PlayerPrefs.SetFloat(MAIN_SOUL,numb);
	}
	public static float getMainSoul() {
		return PlayerPrefs.GetFloat(MAIN_SOUL);
	}

	const string SYSTEM_DATE = "system date";

	public static void setSystemDate (float numb){
		PlayerPrefs.SetFloat(SYSTEM_DATE,numb);
	}
	public static float getSystemDate() {
		return PlayerPrefs.GetFloat(SYSTEM_DATE);
	}

	const string ACTIVE_MAP = "active";

	public static void setActiveMap (int numb){
		PlayerPrefs.SetInt(ACTIVE_MAP,numb);
	}
	public static int getActiveMap() {
		return PlayerPrefs.GetInt(ACTIVE_MAP);
	}

	readonly static string [] LEVEL_MAP = {"level map1","level map2","level map3"};

	public static void setLevelMap (int size,int numb){
		PlayerPrefs.SetInt(LEVEL_MAP[size],numb);
	}
	public static int getLevelMap(int numb) {
		return PlayerPrefs.GetInt(LEVEL_MAP[numb]);
	}

	readonly static string [] MAP1_OBJECT_VALUE =   {"object1","object2","object3","object4","object5","object6"
													,"object7","object8","object9","object10","object11","object12"
													,"object13","object14","object15","object16","object17","object18"
													,"object19","object20","object21","object22","object23","object24"
													,"object25","object26","object27","object28","object29","object30"
													,"object31","object32","object33","object34","object35","object36"
													,"object37","object38","object39","object40","object41","object42"
													,"object43","object44","object45","object46","object47","object48"
													,"object49","object50","object51","object52","object53","object54"
													,"object55","object56","object57","object58","object59","object60"
													,"object61","object62","object63","object64","object65","object66"
													,"object67","object68","object69","object70","object71","object72"
													,"object73","object74","object75","object76","object77","object78"
													,"object79","object80","object81","object82","object83","object84"
													,"object85","object86","object87","object88","object89","object90"
													,"object91","object92","object93","object94","object95","object96"
													,"object97","object98","object99","object100","object101","object102"
													,"object103","object104","object105","object106","object107","object108",
													"object109","object110","object111","object112","object113","object114"};
	
	public static void setMap1ObjectValue (int size,int numb){
		PlayerPrefs.SetInt(MAP1_OBJECT_VALUE[size],numb);
	}
	public static int getMap1ObjectValue(int numb) {
		return PlayerPrefs.GetInt(MAP1_OBJECT_VALUE[numb]);
	}

	readonly static string [] MAP1_OBJECT_NUMBER =   {"object1","object2","object3","object4","object5","object6"
													,"object7","object8","object9","object10","object11","object12"
													,"object13","object14","object15","object16","object17","object18"
													,"object19","object20","object21","object22","object23","object24"
													,"object25","object26","object27","object28","object29","object30"
													,"object31","object32","object33","object34","object35","object36"
													,"object37","object38","object39","object40","object41","object42"
													,"object43","object44","object45","object46","object47","object48"
													,"object49","object50","object51","object52","object53","object54"
													,"object55","object56","object57","object58","object59","object60"
													,"object61","object62","object63","object64","object65","object66"
													,"object67","object68","object69","object70","object71","object72"
													,"object73","object74","object75","object76","object77","object78"
													,"object79","object80","object81","object82","object83","object84"
													,"object85","object86","object87","object88","object89","object90"
													,"object91","object92","object93","object94","object95","object96"
													,"object97","object98","object99","object100","object101","object102"
													,"object103","object104","object105","object106","object107","object108",
													"object109","object110","object111","object112","object113","object114"};
	
	public static void setMap1ObjectNumber (int size,int numb){
		PlayerPrefs.SetInt(MAP1_OBJECT_NUMBER[size],numb);
	}
	public static int getMap1ObjectNumber(int numb) {
		return PlayerPrefs.GetInt(MAP1_OBJECT_NUMBER[numb]);
	}
    
	readonly static string [] MAP2_OBJECT_VALUE =   {"object1","object2","object3","object4","object5","object6"
													,"object7","object8","object9","object10","object11","object12"
													,"object13","object14","object15","object16","object17","object18"
													,"object19","object20","object21","object22","object23","object24"
													,"object25","object26","object27","object28","object29","object30"
													,"object31","object32","object33","object34","object35","object36"
													,"object37","object38","object39","object40","object41","object42"
													,"object43","object44","object45","object46","object47","object48"
													,"object49","object50","object51","object52","object53","object54"
													,"object55","object56","object57","object58","object59","object60"
													,"object61","object62","object63","object64","object65","object66"
													,"object67","object68","object69","object70","object71","object72"
													,"object73","object74"};
	
	public static void setMap2ObjectValue (int size,int numb){
		PlayerPrefs.SetInt(MAP2_OBJECT_VALUE[size],numb);
	}
	public static int getMap2ObjectValue(int numb) {
		return PlayerPrefs.GetInt(MAP2_OBJECT_VALUE[numb]);
	}

	readonly static string [] MAP3_OBJECT_VALUE =   {"object1","object2","object3","object4","object5","object6"
													,"object7","object8","object9","object10","object11","object12"
													,"object13","object14","object15","object16","object17","object18"
													,"object19","object20","object21","object22","object23","object24"
													,"object25","object26","object27","object28","object29","object30"
													,"object31","object32","object33","object34","object35","object36"
													,"object37","object38","object39","object40","object41","object42"
													,"object43","object44","object45","object46","object47","object48"
													,"object49","object50","object51","object52","object53","object54"
													,"object55","object56","object57","object58","object59","object60"
													,"object61","object62","object63","object64","object65","object66"
													,"object67","object68","object69","object70","object71","object72"
													,"object73","object74"};
	
	public static void setMap3ObjectValue (int size,int numb){
		PlayerPrefs.SetInt(MAP3_OBJECT_VALUE[size],numb);
	}
	public static int getMap3ObjectValue(int numb) {
		return PlayerPrefs.GetInt(MAP3_OBJECT_VALUE[numb]);
	}

	readonly static string [] MAP1_UNITS_LEVEL = {"unit1","unit2","unit3","unit4","unit5","unit6","unit7"};
	
	public static void setMap1UnitLevel (int size,int numb){
		PlayerPrefs.SetInt(MAP1_UNITS_LEVEL[size],numb);
	}
	public static int getMap1UnitLevel(int numb) {
		return PlayerPrefs.GetInt(MAP1_UNITS_LEVEL[numb]);
	}
	
	readonly static string [] MAP2_UNITS_LEVEL = {"unit1","unit2","unit3","unit4","unit5","unit6","unit7"
												 ,"unit8","unit9","unit10","unit11","unit12","unit13","unit14"
												 ,"unit5","unit16","unit17"};
	
	public static void setMap2UnitLevel (int size,int numb){
		PlayerPrefs.SetInt(MAP2_UNITS_LEVEL[size],numb);
	}
	public static int getMap2UnitLevel(int numb) {
		return PlayerPrefs.GetInt(MAP2_UNITS_LEVEL[numb]);
	}


	readonly static string [] MAP3_UNITS_LEVEL = {"unit1","unit2","unit3","unit4","unit5","unit6","unit7"
												 ,"unit8","unit9","unit10","unit11","unit12","unit13","unit14"
												 ,"unit5","unit16","unit17"};
	
	public static void setMap3UnitLevel (int size,int numb){
		PlayerPrefs.SetInt(MAP3_UNITS_LEVEL[size],numb);
	}
	public static int getMap3UnitLevel(int numb) {
		return PlayerPrefs.GetInt(MAP3_UNITS_LEVEL[numb]);
	}


	readonly static string [] NOW_BATTARY_VALUE = {" ","K","B","M","T","AA","BB","CC","DD","EE","FF","GG"
                                  					,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                  					,"RR","SS","TT","UU","VV","WW","XX","YY"};
	public static void setNowBattaryValue (int size,float numb){
		PlayerPrefs.SetFloat(NOW_BATTARY_VALUE[size],numb);
	}
	public static float getNowBattaryValue(int numb) {
		return PlayerPrefs.GetFloat(NOW_BATTARY_VALUE[numb]);
	}





	const string BONUS_POWER = "bonus power";

	public static void setBonusPower (float numb){
		PlayerPrefs.SetFloat(BONUS_POWER,numb);
	}
	public static float getBonusPower() {
		return PlayerPrefs.GetFloat(BONUS_POWER);
	}

	const string CRP_GAIN = "crp Gain";

	public static void setCrpGain (float numb){
		PlayerPrefs.SetFloat(CRP_GAIN,numb);
	}
	public static float getCrpGain() {
		return PlayerPrefs.GetFloat(CRP_GAIN);
	}

	const string AUTO_SPEED = "auto speed";

	public static void setAutoSpeed (float numb){
		PlayerPrefs.SetFloat(AUTO_SPEED,numb);
	}
	public static float getAutoSpeed() {
		return PlayerPrefs.GetFloat(AUTO_SPEED);
	}
	const string SOUL_GAIN = "soul gain";

	public static void setSoulGain (float numb){
		PlayerPrefs.SetFloat(AUTO_SPEED,numb);
	}
	public static float getSoulGain() {
		return PlayerPrefs.GetFloat(AUTO_SPEED);
	}

	const string CLICK_NUMB = "click numb";

	public static void setClickNumb (int numb){
		PlayerPrefs.SetInt(CLICK_NUMB,numb);
	}
	public static int getClickNumb() {
		return PlayerPrefs.GetInt(CLICK_NUMB);
	}

	const string GOLD_QUEST = "gold quest";

	public static void setGoldQuest (int numb){
		PlayerPrefs.SetInt(GOLD_QUEST,numb);
	}
	public static int getGoldQuest() {
		return PlayerPrefs.GetInt(GOLD_QUEST);
	}

	const string WATCH_ADS_NUMB = "watch ads numb";

	public static void setWatchAdsNumb (int numb){
		PlayerPrefs.SetInt(WATCH_ADS_NUMB,numb);
	}
	public static int getWatchAdsNumb() {
		return PlayerPrefs.GetInt(WATCH_ADS_NUMB);
	}

	const string UNIT_UPGRADE_NUMB = "unit upgrade numb";

	public static void setUnitUpgradeNumb (int numb){
		PlayerPrefs.SetInt(UNIT_UPGRADE_NUMB,numb);
	}
	public static int getUnitUpgradeNumb() {
		return PlayerPrefs.GetInt(UNIT_UPGRADE_NUMB);
	}

	const string OPEN_DAY = "open day";

	public static void setOpenDay (int numb){
		PlayerPrefs.SetInt(OPEN_DAY,numb);
	}
	public static int getOpenDay() {
		return PlayerPrefs.GetInt(OPEN_DAY);
	}

	const string OPEN_MAP = "open map";

	public static void setOpenMap (int numb){
		PlayerPrefs.SetInt(OPEN_MAP,numb);
	}
	public static int getOpenMap() {
		return PlayerPrefs.GetInt(OPEN_MAP);
	}


    // Start is called before the first frame update
    private void Awake() {
		PlayerPrefs.DeleteAll();
		setMainGold1(4,10f);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
