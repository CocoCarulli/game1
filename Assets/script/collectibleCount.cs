using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleCount : MonoBehaviour
{
   TMPro.TMP_Text text;
   int count;

   void Awake()
   {
    text = GetComponent<TMPro.TMP_Text>();
   }

   void Start() => UpdateCount();
    void OnEnable() => collectable.OnCollected += OnCollectibleCollected;
    void OnDisable() => collectable.OnCollected -= OnCollectibleCollected;

   void OnCollectibleCollected()
   {
    count++;
    UpdateCount();

   }

   void UpdateCount()
   {
    text.text = $"{count} / {collectable.total}";
   }
}
