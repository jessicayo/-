namespace VRTK.Examples
{
    using UnityEngine;
    using System;
    using System.Collections;

    public class RemoveDust : VRTK_InteractableObject
    {
        public GameObject WaterParticle;
        public AudioSource WaterAudio;
        public GameObject DustParticleOne;
        public GameObject DustParticleTwo;
        public GameObject DustParticleThree;
        public GameObject ArrowParticle;
        public AudioSource threeAudio;
        public GameObject chuchenUI;
        public GameObject shiquShuiUI;

        //public GameObject HuiCheng;
        //public GameObject HuiChengOne;
        //public GameObject HuiChengTwo;

        public Collider four;
       

        public override void Grabbed(VRTK_InteractGrab currentGrabbingObject = null)
        {
            base.Grabbed(currentGrabbingObject);
            WaterParticle.SetActive(true);
            WaterAudio.Play();
            shiquShuiUI.SetActive(false);
            StartCoroutine(Wait());
            
        }

        public override void Ungrabbed(VRTK_InteractGrab previousGrabbingObject = null)
        {
            base.Ungrabbed(previousGrabbingObject);
            WaterParticle.SetActive(false);
            WaterAudio.Pause();
        }
        


        protected override void Update()
        {
            base.Update();   
        }
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);
            ArrowParticle.SetActive(false);
            yield return new WaitForSeconds(15.0f);
            DustParticleOne.SetActive(false);
            yield return new WaitForSeconds(1.5f);
            DustParticleTwo.SetActive(false);
            yield return new WaitForSeconds(4.0f);
            DustParticleThree.SetActive(false);
            chuchenUI.SetActive(true);
            yield return new WaitForSeconds(3.0f);
            chuchenUI.SetActive(false);
            threeAudio.Play();
            //HuiCheng.SetActive(true);
            //yield return new WaitForSeconds(4.0f);
            //HuiChengOne.SetActive(true);
            //HuiCheng.SetActive(false);
            //yield return new WaitForSeconds(4.0f);
            //HuiChengTwo.SetActive(true);
            //HuiChengOne.SetActive(false);
            //yield return new WaitForSeconds(4.0f);
            //HuiChengTwo.SetActive(false);
            four.enabled = true;
        }
    }
}