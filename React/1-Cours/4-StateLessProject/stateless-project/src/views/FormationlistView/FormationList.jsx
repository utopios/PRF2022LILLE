import {React , useState} from 'react';
import Category from '../../components/CategoryComponent/Category';
import { coursList } from '../../datas/CoursList';
import FormationCard from '../../components/FormationCardComponent/FormationCard';

const FormationList = () => {

    const[activeCategory, setActiveCategory] = useState('');

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
                        <Category 
                            categoryList={categoryList} 
                            activeCategory = {activeCategory}
                            setActiveCategory = {setActiveCategory}
                        />
                    </div>
                    <div className="col-2 paddingTop">
                        {/* Cart */}
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours,index)=>
                    !activeCategory || activeCategory === cours.category?
                    <div key={index} >
                        <FormationCard 
                            name={cours.name}
                            logo={cours.logo}
                            category={cours.category}
                            difficulte={cours.difficulte}
                            price={cours.price}
                            index={index}
                        />                        
                    </div>
                    :
                    null
                )}
            </div>
        </div>
    );
};

export default FormationList;