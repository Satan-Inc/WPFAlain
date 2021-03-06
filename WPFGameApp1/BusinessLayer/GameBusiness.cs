﻿using System;
using System.Collections.Generic;
using System.Text;
using WPFGameApp1.PresentationLayer;
using WPFGameApp1.DataLayer;
using WPFGameApp1.Models;

namespace WPFGameApp1.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        List<Player> _player = new List<Player>();
        List<Spell> _spells = new List<Spell>();
        List<SpellComponent> _spellComponentList = new List<SpellComponent>();

        public GameBusiness()
        {
            InitializeDataSet();
            InstantiateAndShowView();
        }

        private void InitializeDataSet()
        {
            _player = GameData.PlayerList();
            _spells = GameData.SpellList();
            _spellComponentList = GameData.SpellComponentList();
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(_player, _spells, _spellComponentList);

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();
        }
    }
}
