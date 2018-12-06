
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controler{
    public class RestaurantController {

        public RestaurantController() {
        }

        public int CustomerNumber;

        public Model RestaurantModel;

        public IHM RestaurantView;

        public int SpeedTime;

        /// <summary>
        /// @param restaurantModel 
        /// @param restaurantView
        /// </summary>
        public void RestaurantController(RestaurantModel restaurantModel, RestaurantView restaurantView) {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public void StartNewDay() {
            // TODO implement here
            return null;
        }

        public void CreateRestaurant() {
            // TODO implement here
        }

        public void Pause() {
            // TODO implement here
        }

        public void Continue() {
            // TODO implement here
        }

        public void Accelerate() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public RestaurantView GetRestaurantView() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public RestaurantModel GetRestaurantModel() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @param restaurantView 
        /// @return
        /// </summary>
        public void SetRestaurantView(RestaurantView restaurantView) {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @param restaurantModel 
        /// @return
        /// </summary>
        public void SetRestaurantModel(RestaurantModel restaurantModel) {
            // TODO implement here
            return null;
        }

    }
}