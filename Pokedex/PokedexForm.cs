using Pokedex.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class PokedexForm : Form
    {
        readonly PokemonHandler handler;
        public PokedexForm()
        {
            InitializeComponent();
            handler = new PokemonHandler(); 
        }

        private void CleanFields()
        {
            ImageBackBox.ImageLocation = string.Empty;
            ImageFrontBox.ImageLocation = string.Empty;
            NumberInfoLabel.Text = string.Empty;
            NameInfoLabel.Text = string.Empty;
            TypeInfoLabel.Text = string.Empty;
            HeightInfoLabel.Text = string.Empty;
            WeightInfoLabel.Text = string.Empty;
            BaseExperienceInfoLabel.Text = string.Empty;
            MovementsListView.Items.Clear();
            StatsListView.Items.Clear();
            AbilitiesListView.Items.Clear();
            ProgressBar.Value = 0;
            handler.pokemon = null;
            handler.evolutionChain = null;
            handler.evolutionPokemon = null;
        }


        private async void SearchButton_Click(object sender, EventArgs e)
        {
            CleanFields();
            if (SearchBox.Text != string.Empty)
            {
                ProgressBar.Visible = true;
                ProgressBar.Value = 80;
                await handler.GetPokemon(SearchBox.Text.ToLower());
                ProgressBar.Value = 100;
                if (handler.pokemon != null)
                {
                    ImageBackBox.ImageLocation = handler.pokemon.Sprites.BackDefault;
                    ImageFrontBox.ImageLocation = handler.pokemon.Sprites.FrontDefault;
                    NumberInfoLabel.Text = handler.pokemon.PokemonID.ToString();
                    NameInfoLabel.Text = handler.pokemon.GetName();
                    TypeInfoLabel.Text = handler.pokemon.GetTypesLabel();
                    HeightInfoLabel.Text = handler.pokemon.Height;
                    WeightInfoLabel.Text = handler.pokemon.Weight;
                    BaseExperienceInfoLabel.Text = handler.pokemon.BaseExperience.ToString();
                    foreach(var Move in handler.pokemon.Moves)
                    {
                        ListViewItem item = new(Move.Move.GetName());
                        MovementsListView.Items.Add(item);
                    }
                    foreach (var Stat in handler.pokemon.Stats)
                    {
                        ListViewItem item = new(Stat.Stat.GetName());
                        item.SubItems.Add(Stat.BaseStat);
                        item.SubItems.Add(Stat.Effort);
                        StatsListView.Items.Add(item);
                    }
                    foreach (var Ability in handler.pokemon.Abilities)
                    {
                        ListViewItem item = new(Ability.Ability.GetName());
                        item.SubItems.Add(Ability.IsHidden);
                        AbilitiesListView.Items.Add(item);
                    }
                    // MessageBox.Show(handler.PokemonToString());
                }
                else
                {
                    MessageBox.Show("Pokemon not found.", "Pokemon not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Search is empty.", "Search is empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProgressBar.Visible = false;
        }

        private async void EvolutionsButton_Click(object sender, EventArgs e)
        {
            if (handler.pokemon != null)
            {
                await handler.GetEvolutionChain();
                EvolutionChainForm evolutionChainForm = new (handler);
                evolutionChainForm.Show();
            }
            else
            {
                MessageBox.Show("Search is empty.", "Search is empty.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
