using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NaverSDK : MonoBehaviour {


    public void gotoProfile()
    {
        GLink.sharedInstance().executeProfile();
    }

    public void gotoHome()
    {
        GLink.sharedInstance().executeHome();
    }

    public void gotoMenu()
    {
        GLink.sharedInstance().executeMenu();
    }
    
    public void gotoNotice()
    {
        GLink.sharedInstance().executeNotice();
    }

    public void gotoEvnet()
    {
        GLink.sharedInstance().executeEvent();
    }
    
}
