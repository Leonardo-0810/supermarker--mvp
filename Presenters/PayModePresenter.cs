using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }

        private void AddNewPayMode(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields(); // Limpiar los campos cuando se añade un nuevo registro
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object sender, EventArgs e)
        {
            // Se crea un objeto de la clase PayModeModel y se asignan los datos de la vista
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;
            try
            {
                new Common.ModelDataValidation().Validate(payMode); // Validación del modelo
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited successfully";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added successfully";
                }
                view.IsSuccessful = true; // Operación exitosa
                loadAllPayModeList(); // Recargar la lista
                CleanViewFields(); // Limpiar los campos
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false; // Operación fallida
                view.Message = ex.Message; // Mostrar el mensaje de error
            }
        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay un objeto seleccionado
                var payMode = (PayModeModel)payModeBindingSource.Current;
                if (payMode == null || payMode.Id == 0)
                {
                    view.Message = "Please select a valid pay mode to delete.";
                    return;
                }

                // Se invoca el método Delete del repositorio pasándole el ID del Pay Mode
                repository.Delete(payMode.Id);

                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted successfully";

                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete pay mode: " + ex.Message;
            }
        }


        private void LoadSelectPayModeToEdit(object sender, EventArgs e)
        {
            // Se obtiene el objeto seleccionado del DataGridView
            var payMode = (PayModeModel)payModeBindingSource.Current;
            // Se actualizan los campos de la vista con los valores del objeto seleccionado
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;
            view.IsEdit = true; // Se establece el modo edición
        }

        private void SearchPayMode(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}

