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
    using UnityEngine.UI;
    using uFrame.ECS;
    using UnityEngine;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("884a6ce9-7c4d-409a-a52f-05bf615ac5cc")]
    public partial class ScoreText : uFrame.ECS.EcsComponent {
        
        private Subject<UnityEngine.UI.Text> _TextObservable;
        
        private Subject<System.String> _fdsdfObservable;
        
        [UnityEngine.SerializeField()]
        private UnityEngine.UI.Text _Text;
        
        [UnityEngine.SerializeField()]
        private string _fdsdf;
        
        public int ComponentID {
            get {
                return 13;
            }
        }
        
        public IObservable<UnityEngine.UI.Text> TextObservable {
            get {
                if (_TextObservable == null) {
                    _TextObservable = new Subject<UnityEngine.UI.Text>();
                }
                return _TextObservable;
            }
        }
        
        public IObservable<System.String> fdsdfObservable {
            get {
                if (_fdsdfObservable == null) {
                    _fdsdfObservable = new Subject<System.String>();
                }
                return _fdsdfObservable;
            }
        }
        
        public UnityEngine.UI.Text Text {
            get {
                return _Text;
            }
            set {
                _Text = value;
                if (_TextObservable != null) {
                    _TextObservable.OnNext(value);
                }
            }
        }
        
        public string fdsdf {
            get {
                return _fdsdf;
            }
            set {
                _fdsdf = value;
                if (_fdsdfObservable != null) {
                    _fdsdfObservable.OnNext(value);
                }
            }
        }
    }
}
