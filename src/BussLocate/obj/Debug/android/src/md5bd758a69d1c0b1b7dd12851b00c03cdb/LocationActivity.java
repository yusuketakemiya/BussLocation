package md5bd758a69d1c0b1b7dd12851b00c03cdb;


public class LocationActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BussLocateTest.Activityes.LocationActivity, BussLocateTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LocationActivity.class, __md_methods);
	}


	public LocationActivity ()
	{
		super ();
		if (getClass () == LocationActivity.class)
			mono.android.TypeManager.Activate ("BussLocateTest.Activityes.LocationActivity, BussLocateTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
