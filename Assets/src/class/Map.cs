/** Game Map Creator Class
 * 	@author Jose Luis Jimenez Urbano | < ijos@ijos.es >
 **/ 
using UnityEngine;
using System.Collections;

public class Map {

	/**
	 * @brief This method creates a map which center is 0,0,0
	 * @author Jose Luis Jimenez Urbano | < ijos@ijos.es >
	 **/
	public static void createMap(){
		// Create a basic Squares Map
		float cube_width_			= 1.0f;
		float cube_height_			= 0.1f;
		float cube_deep_			= 1.0f;

		float starting_point_x_ 	= 0.0f;
		float starting_point_y_ 	= 0.0f;
		float starting_point_z_ 	= 0.0f;
		int map_side_size_			= 20; // --> From center 128x128 blocks
		int map_layers_				= 5;
		float highness				= 0;

		float drawing_point_x		= starting_point_x_ - (map_side_size_ / 2);
		float drawing_point_z		= starting_point_z_ - (map_side_size_ / 2);


		GameObject map_container = new GameObject();
		map_container.name = "Map";

		for(int y = 0; y < map_layers_; y++){
			for(int z = 0; z < map_side_size_; z++){
				for(int x = 0; x < map_side_size_; x++){
					//SimpleProceduralCube simple_procedural_cube = new SimpleProceduralCube();
					SimpleProceduralCube simple_procedural_cube = ScriptableObject.CreateInstance("SimpleProceduralCube")as SimpleProceduralCube; // New way to do this, removed above!
					GameObject cube = simple_procedural_cube.createCube(new Vector3(drawing_point_x + x, starting_point_y_ + highness, drawing_point_z + z), new Vector3(cube_width_, cube_height_, cube_deep_));
					cube.transform.parent = map_container.transform;
				}
			}
			highness += cube_height_;
		}

	}

}
