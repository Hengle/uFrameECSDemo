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
    
    
    public class UISystemPointerClickDispatcherHandler {
        
        public PlayGameButton EntityId;
        
        private uFrame.ECS.PointerClickDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject LoopCollectionNode25_Item = default( UnityEngine.GameObject );
        
        private UnityEngine.GameObject ActionNode26_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode26_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode26_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode26_Result = default( UnityEngine.GameObject );
        
        public uFrame.ECS.PointerClickDispatcher Event {
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
            // LoopCollectionNode
            while (this.DebugInfo("d86d476a-60a8-46bf-b1e1-90583786c467","d2e5988d-36b5-4350-82ad-93d52f3e3817", this) == 1) yield return null;
            for (var LoopCollectionNode25_ItemIndex = 0
            ; LoopCollectionNode25_ItemIndex < EntityId.InstantiateItems.Count; LoopCollectionNode25_ItemIndex++
            ) {
                LoopCollectionNode25_Item = EntityId.InstantiateItems[LoopCollectionNode25_ItemIndex];
                System.StartCoroutine(LoopCollectionNode25_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopCollectionNode25_Next() {
            ActionNode26_gameObject = LoopCollectionNode25_Item;
            // ActionNode
            while (this.DebugInfo("d2e5988d-36b5-4350-82ad-93d52f3e3817","03db7d7e-7273-499f-b530-127999b3f37c", this) == 1) yield return null;
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode26_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode26_gameObject, ActionNode26_position, ActionNode26_rotation);
            yield break;
        }
    }
}