import React from "react";
import { DataTable } from 'primereact/datatable';
import { Column } from 'primereact/column';

const DataGrid = (props) => {
    return  <>
        {
            (props.data.length > 0) ?
                <div className="datatable-responsive-demo">
                    <div className="card">
                        <DataTable value={props.data} className="p-datatable-striped" paginator rows={10} >
                            {
                                props.columns.map((col, i) => <Column key={col.field} field={col.field} header={col.header} body={col.body} />)
                            }
                        </DataTable>
                    </div>
                </div> :
                <h1>THERE IS NO RECORD</h1>
        }
    </>


}

export default DataGrid;
