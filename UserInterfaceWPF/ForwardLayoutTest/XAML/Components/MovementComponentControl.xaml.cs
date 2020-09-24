﻿using ForwardLayoutTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Entities;
using MakerSquare.FrontFacingECS;
using ForwardLayoutTest.Controller;

namespace ForwardLayoutTest.XAML.Components
{
    [Serializable]
    public class MovementComponentSerializedData : ISerializedComponent
    {
        public void SetComponentData(Entity entity)
        {            
        }
    }

    /// <summary>
    /// Logique d'interaction pour MovementComponent.xaml
    /// </summary>
    public partial class MovementComponentControl : UserControl, IComponent
    {
        public Entity selectedEntity { get; set; }
        public List<FFComponent> engineData { get; set; }

        public MovementComponentControl(Entity entity)
        {
            InitializeComponent();
            engineData = new List<FFComponent>();
            selectedEntity = entity;
        }

        public void FillData()
        {
            engineData.Add(new FFMovement(selectedEntity));
        }

        public void deleteComponent(object sender, RoutedEventArgs e)
        {
            var CMC = ContextMenuController.GetInstance();
            CMC.DeleteComponent(this);
        }

        public void AddSerializedComponent(Entity entity)
        {            
        }
    }
}