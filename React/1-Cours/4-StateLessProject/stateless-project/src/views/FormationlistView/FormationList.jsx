import React from 'react';
import Category from '../../components/CategoryComponent/Category';
import { coursList } from '../../datas/CoursList';

const FormationList = () => {

    const categoryList = coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    )
    //console.log("CategoryList : "+categoryList);

    return (
        <div className="formation-list">

            <h2>Nos Formations</h2>
            <div>
                <div className="row">
                    <div className="col-8">
                        <Category categoryList={categoryList}/>
                    </div>
                    <div className="col-2 paddingTop">
                        {/* Cart */}
                    </div>
                </div>
            </div>
        </div>
    );
};

export default FormationList;