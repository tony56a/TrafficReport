﻿
using ICities;
using UnityEngine;

using ColossalFramework.Plugins;
using ColossalFramework;
using ColossalFramework.UI;

using System.Reflection;
using System;
using TrafficReport.Util;
using TrafficReport.Assets.Source.UI;
using System.Collections.Generic;

namespace TrafficReport
{
      
    public class TrafficReportMod : LoadingExtensionBase, IUserMod
    {

		QueryTool queryTool;
    
        public string Name
        {
            get { return "Traffic Report Tool 2.0, Updated"; }
        }
        public string Description
        {
            get {

                return "Display traffic information for a single vehicle, a section of road or a building"; 
            
            }
        }

        public override void OnCreated(ILoading loading) {
        	Log.info ("onLoaded");
		}

		public override void OnReleased() {
			Log.info ("onReleased");
		}

        public override void OnLevelLoaded(LoadMode mode)
        {
            GameObject gameController = GameObject.FindWithTag("GameController");
            if (gameController)
            {
                Log.debug(gameController.ToString());
                queryTool = gameController.AddComponent<QueryTool>();
                queryTool.enabled = false;

            }
                              
        }


    }

 }

