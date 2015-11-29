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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    [uFrame.Attributes.ComponentId(1)]
    [uFrame.Attributes.uFrameIdentifier("092f8558-a85c-4579-b569-09b513eda0b1")]
    public partial class GunnerInput : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Button _MyButton;
        
        private Subject<PropertyChangedEvent<Button>> _MyButtonObservable;
        
        private PropertyChangedEvent<Button> _MyButtonEvent;
        
        public override int ComponentId {
            get {
                return 1;
            }
        }
        
        public IObservable<PropertyChangedEvent<Button>> MyButtonObservable {
            get {
                return _MyButtonObservable ?? (_MyButtonObservable = new Subject<PropertyChangedEvent<Button>>());
            }
        }
        
        public Button MyButton {
            get {
                return _MyButton;
            }
            set {
                SetMyButton(value);
            }
        }
        
        public virtual void SetMyButton(Button value) {
            SetProperty(ref _MyButton, value, ref _MyButtonEvent, _MyButtonObservable);
        }
    }
}
