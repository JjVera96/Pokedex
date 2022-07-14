using Pokedex.Handlers;
using Pokedex.Models;
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
    public partial class EvolutionChainForm : Form
    {
        readonly PokemonHandler handler;
        public EvolutionChainForm(PokemonHandler _handler)
        {
            InitializeComponent();
            handler = _handler;
            ShowEvolution();
        }

        private void AddChild(TreeNode node, Chain tree)
        {
            if (tree != null)
            {
                TreeNode newNode = node.Nodes.Add(tree.Species.GetName());
                foreach (Chain child in tree.EvolvesTo)
                {
                    AddChild(newNode, child);
                }
            }
        }

        public void ShowEvolution()
        {
            if (handler.evolutionChain != null)
            {
                TreeNode node = EvolutionTreeView.Nodes.Add(handler.evolutionChain.Chain.Species.GetName());
                foreach (Chain child in handler.evolutionChain.Chain.EvolvesTo)
                {
                    AddChild(node, child);
                }
            }
            else
            {
                MessageBox.Show("Evolution tree not found.", "Evolution tree not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EvolutionTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            if (node != null)
            {
                await handler.GetEvolutionPokemon(node.Text.ToLower());
                if (handler.evolutionPokemon != null)
                {
                    ImageBackBox.ImageLocation = handler.evolutionPokemon.Sprites.BackDefault;
                    ImageFrontBox.ImageLocation = handler.evolutionPokemon.Sprites.FrontDefault;
                }
                else {
                    MessageBox.Show("Pokemon not found.", "Pokemon not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Node is not selected", "Node is not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
