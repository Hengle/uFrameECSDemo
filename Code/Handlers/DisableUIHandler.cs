// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class DisableUIComponentCreated {
        
        public WavesGame Group;
        
        private WavesGame _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private uFrameECSDemo.MenuUI LoopGroupNode32_Item = default( uFrameECSDemo.MenuUI );
        
        private UnityEngine.GameObject ActionNode33_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode33_behaviour = default( UnityEngine.MonoBehaviour );
        
        public WavesGame Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            // LoopGroupNode
            while (this.DebugInfo("42976861-8c91-41e7-9188-a0de2f8a460d","7bfcb8c0-5cdc-4130-a288-0916d2a551ac", this) == 1) yield return null;
            var LoopGroupNode32_GroupComponents = System.ComponentSystem.RegisterComponent<uFrameECSDemo.MenuUI>().Components;
            for (var LoopGroupNode32_ItemIndex = 0
            ; LoopGroupNode32_ItemIndex < LoopGroupNode32_GroupComponents.Count; LoopGroupNode32_ItemIndex++
            ) {
                LoopGroupNode32_Item = LoopGroupNode32_GroupComponents[LoopGroupNode32_ItemIndex];
                System.StartCoroutine(LoopGroupNode32_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopGroupNode32_Next() {
            ActionNode33_gameObject = LoopGroupNode32_Item.gameObject;
            // ActionNode
            while (this.DebugInfo("7bfcb8c0-5cdc-4130-a288-0916d2a551ac","fd87d60b-7ed8-4917-af15-d43272ae48ed", this) == 1) yield return null;
            // Visit uFrame.Actions.GameObjects.DeactiateGameObject
            uFrame.Actions.GameObjects.DeactiateGameObject(ActionNode33_gameObject, ActionNode33_behaviour);
            yield break;
        }
    }
}