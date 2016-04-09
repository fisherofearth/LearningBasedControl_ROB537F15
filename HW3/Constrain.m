function [ verify ] = Constrain( state, action, mapSize )
%CONSTRAIN Summary of this function goes here
%   Detailed explanation goes here
    newState = state + action;
    
    if (newState(1)<=0)
       verify = -1;
    elseif (newState(1)>mapSize(1))
       verify = -1; 
    elseif (newState(2)<=0)
       verify = -1;
    elseif (newState(2)>mapSize(2))
       verify = -1;
    else
       verify = 1;
    end 

end

