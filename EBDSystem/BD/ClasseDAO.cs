using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;
using EBDSystem.Util;
using System.Windows.Forms;

namespace EBDSystem.BD
{
    class ClasseDAO : DAO
    {
        public bool inserir(ClasseEntity classeEntity)
        {
            classe classe = new classe();
            classe.nome = classeEntity.Nome;
            DB.classes.InsertOnSubmit(classe);

            try
            {
                DB.SubmitChanges();
                classeEntity.Id = classe.id;
                if (classeEntity.Professores.Count > 0)
                {
                    foreach (PessoaEntity professor in classeEntity.Professores.Values)
                    {
                        professor_classe pfClasse = new professor_classe();
                        pfClasse.id_classe = classe.id;
                        pfClasse.id_pessoa = professor.Id;
                        DB.professor_classes.InsertOnSubmit(pfClasse);
                        DB.SubmitChanges();
                    }
                }

                DB.SubmitChanges();
                MessageBox.Show("Classe inserida com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Classe", Validator.INSERIR, ex.Message);
                DB.Transaction.Rollback();
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool editar(ClasseEntity classeEntity, List<int>idsExcluirProfessor)
        {
            var query = from c in DB.classes where c.id == classeEntity.Id select c;
            foreach (classe ci in query)
            {
                ci.nome = classeEntity.Nome;
            }
            try
            {
                DB.SubmitChanges();
                if (idsExcluirProfessor.Count > 0)
                {
                    foreach (int idpessoa in idsExcluirProfessor)
                    {
                        var queryClasses = from c in DB.professor_classes
                                           where c.id_classe == classeEntity.Id
                                           where c.id_pessoa == idpessoa
                                           select c;
                        foreach (professor_classe pc in queryClasses)
                        {
                            DB.professor_classes.DeleteOnSubmit(pc);
                            DB.SubmitChanges();
                        }
                    }
                }
                if (classeEntity.Professores.Count > 0)
                {
                    //exclui todos os professores e inclui novamente
                    var classeProfessor = from cp in DB.professor_classes
                                          where cp.classe.id == classeEntity.Id
                                          select cp;
                    foreach (var cp in classeProfessor)
                    {
                        DB.professor_classes.DeleteOnSubmit(cp);
                    }
                    foreach (PessoaEntity professor in classeEntity.Professores.Values)
                    {
                        professor_classe pfClasse = new professor_classe();
                        pfClasse.id_classe = classeEntity.Id;
                        pfClasse.id_pessoa = professor.Id;
                        DB.professor_classes.InsertOnSubmit(pfClasse);
                        DB.SubmitChanges();
                    }
                }
                MessageBox.Show("Classe editada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Classe", Validator.EDITAR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool excluir(int id)
        {
            try
            {
                var classeProfessor = from cp in DB.professor_classes
                                  where cp.classe.id == id
                                  select cp;
                foreach (var cp in classeProfessor)
                {
                    DB.professor_classes.DeleteOnSubmit(cp);
                }
                var queryClasse = from c in DB.classes
                                  where c.id == id
                                  select c;
                foreach(var c in queryClasse)
                {
                    DB.classes.DeleteOnSubmit(c);
                }
                MessageBox.Show("Classe excluída com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }catch(Exception ex)
            {
                Validator.tratarErrosSql("Classe", Validator.EXCLUIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }
        public ClasseEntity getClasseComProfessores(int id)
        {
            ClasseEntity classeEntity = new ClasseEntity();
            var query = from cp in DB.professor_classes
                        where cp.id_classe == id
                        orderby cp.classe.nome
                        select new { cp.id_classe, nomeClasse = cp.classe.nome, cp.professor};
            foreach(var cp in query)
            {
                classeEntity.Id = cp.id_classe;
                classeEntity.Nome = cp.nomeClasse;
                PessoaEntity professor = new PessoaEntity();
                professor.Id = cp.professor.id;
                professor.Nome = cp.professor.nome;
                professor.DataNascimento = (DateTime)cp.professor.data_nascimento;
                classeEntity.Professores.Add(professor.Id, professor);
            }
            return classeEntity;
        }

        public DataTable getClasses()
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[] {
                new DataColumn("Código", typeof(Int32)),
                new DataColumn("Nome", typeof(String))
            });
            var query = from c in DB.classes
                        select new { c.id, c.nome };

            foreach (var c in query)
            {
               data.Rows.Add(new Object[] { c.id, c.nome });
            }
            return data;
        }
        public override Entity getEntityByIdentificador(int id)
        {
            ClasseEntity classe = new ClasseEntity();
            var query = from c in DB.classes
                        where c.id == id
                        select new { c.id, c.nome };
            foreach(var c in query)
            {
                classe.Id = c.id;
                classe.Nome = c.nome;
            }
            return classe;       
        }

        public override DataTable getSource(string search)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[] {
                new DataColumn("Código", typeof(Int32)),
                new DataColumn("Nome", typeof(String))
            });
            if (search != null)
            {
                var query = from c in DB.classes
                            where c.nome.Contains(search)
                            select new { c.id, c.nome };

                foreach (var c in query)
                {
                    data.Rows.Add(new Object[] { c.id, c.nome });
                }
            }
            return data;
        }
    }
}
