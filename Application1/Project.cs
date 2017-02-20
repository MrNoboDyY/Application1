using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
   public class Project
    {
        private string path;
        private DataTable data = new DataTable();
        private bool hasChanged;
        private string filename;

        public string Filename
        {
            get
            {return filename;}


            /*mettre a jour le champ HasChanged si modif !!!*/
            protected set
            {/*filename = value;*/
                if (this.filename != value)
                {
                    this.filename = value;
                    this.HasChanged = true;
                }
            }
        }

        public string Path
        {
            get
            {return path;}

            protected set
            {/*path = value;*/
                if (this.path != value)
                {
                    this.path = value;
                    this.HasChanged = true;
                }
            }
        }

        public DataTable Data
        {
            get
            {return data;}

            protected set
            {/*data = value;*/
                if (this.data != value)
                {
                    this.data = value;
                    this.HasChanged = true;
                }
            }
        }


        /*si l'objet est modifié!!!*/
        public bool HasChanged
        {
            get
            {return hasChanged;}

            set
            {hasChanged = value;}
        }

        ///<summary>
        ///Sauvegarder le projet
        ///</summary>
        ///<param name="Ask">Spécifie si l'utilisateur doit confirmer
        ///la sauvegarde.</param>
        ///<param name="ShowDialog">Specifie si l'utilisateur a la possibilité 
        ///de choisir le fichier.</param>
        public void Save(bool Ask,bool ShowDialog)
        {
            /*Si l'utilisateur doit confirmer la sauvegarde et que 
             le projet a ete modifié,l'utilisateur doit cliquer sur
             le bouton Oui de la boite de dialogue*/
            if (!Ask || (this.HasChanged && MessageBox.Show(
                "Voulez-vous sauvegarder les modifs ?",                
                "Sauvegarder",MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                /*Si l'utilisateur n'a pas la possibilité de choisir 
                 un fichier et que le nom du fichier ainsi que son chemin sont definis,
                 le projet est enregistré et la propriété HasChanged est reinitialisée */
                 if(!ShowDialog && 
                    !string.IsNullOrEmpty(this.Filename) 
                    &&
                    !string.IsNullOrEmpty(this.Path)){
                    this.HasChanged = false;
                }
                /*Dans le cas contraire l'utilisateur doit choisir 
                 un nom de fichier et un chemin pour le projet 
                 qui sera enregistré*/
                else
                {
                    /*Instanciation et initialisation de la boite de dialogue*/
                    SaveFileDialog sfdProject = new SaveFileDialog();
                    sfdProject.Filter = "Self Mailer"(*.smpx) | *.smpx;
                    sfdProject.RestoreDirectory = true;
                    sfdProject.SupportMultiDotteExtensions = true;
                    sfdProject.Title = "Sauver le Projet";
                    /*Affichage de la boite de dialogue et test de la valeur de retour */
                    if (sfdProject.ShowDialog() == DialogResult.OK)
                    {
                        /*Assignation des valeurs aux variables et 
                         sauvegarde du projet*/
                        this.Filename = 
                            System.IO.Path.GetFileName(sfdProject.Filename);
                        this.Path =
                            System.IO.Path.GetDirectoryName(sfdProject.Filename);
                        //Sauvegarde des données non implementées
                        this.HasChanged=false;

                    }
                        
                }
            }

        }

        
    }

}
